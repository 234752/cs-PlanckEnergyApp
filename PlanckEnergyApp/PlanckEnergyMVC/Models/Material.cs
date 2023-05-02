namespace PlanckEnergyMVC.Models;

public class Material
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string _chemical_formula_moiety { get; set; }
    public string _symmetry_cell_setting { get; set; }
    public string _symmetry_space_group_name_H_M { get; set; }
    public string _symmetry_Int_Tables_number { get; set; }
    public string _space_group_name_Hall { get; set; }
    public string _cell_length_a { get; set; }
    public string _cell_length_b { get; set; }
    public string _cell_length_c { get; set; }
    public string _cell_angle_alpha { get; set; }
    public string _cell_angle_beta { get; set; }
    public string _cell_angle_gamma { get; set; }
    public string _cell_volume { get; set; }
}
