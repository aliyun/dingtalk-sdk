<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\PublishSchoolReportRequest\classDetailItems\studentDetailList;

use AlibabaCloud\Tea\Model;

class subjectList extends Model
{
    /**
     * @var int
     */
    public $gradeRank;

    /**
     * @var string
     */
    public $levelScore;

    /**
     * @var string
     */
    public $name;

    /**
     * @var float
     */
    public $score;
    protected $_name = [
        'gradeRank' => 'gradeRank',
        'levelScore' => 'levelScore',
        'name' => 'name',
        'score' => 'score',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->gradeRank) {
            $res['gradeRank'] = $this->gradeRank;
        }
        if (null !== $this->levelScore) {
            $res['levelScore'] = $this->levelScore;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->score) {
            $res['score'] = $this->score;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subjectList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['gradeRank'])) {
            $model->gradeRank = $map['gradeRank'];
        }
        if (isset($map['levelScore'])) {
            $model->levelScore = $map['levelScore'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['score'])) {
            $model->score = $map['score'];
        }

        return $model;
    }
}
