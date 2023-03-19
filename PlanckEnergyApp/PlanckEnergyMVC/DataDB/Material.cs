using System;
using System.Collections.Generic;

namespace PlanckEnergyMVC.DataDB;

public partial class Material
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? ChemicalFormulaMoiety { get; set; }

    public string? SymmetryCellSetting { get; set; }

    public string? SymmetrySpaceGroupNameHM { get; set; }

    public string? SymmetryIntTablesNumber { get; set; }

    public string? SpaceGroupNameHall { get; set; }

    public string? CellLengthA { get; set; }

    public string? CellLengthB { get; set; }

    public string? CellLengthC { get; set; }

    public string? CellAngleAlpha { get; set; }

    public string? CellAngleBeta { get; set; }

    public string? CellAngleGamma { get; set; }

    public string? CellVolume { get; set; }
}
