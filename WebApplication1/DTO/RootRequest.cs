using System;
using System.Collections.Generic;

namespace WebApplication1.DTO;

public class RootRequest
{
    public int id { get; set; }
    public string thirdPartyCandidateId { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public DateTime birthdate { get; set; }
    public int gender { get; set; }
    public int hiredInPositionId { get; set; }
    public List<PositionList> positionList { get; set; }
    public Details details { get; set; }
}