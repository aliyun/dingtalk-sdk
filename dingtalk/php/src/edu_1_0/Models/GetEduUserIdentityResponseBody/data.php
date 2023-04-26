<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\GetEduUserIdentityResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var bool
     */
    public $matchGuardianRule;

    /**
     * @var bool
     */
    public $matchTeacherRule;

    /**
     * @var string
     */
    public $unionId;
    protected $_name = [
        'matchGuardianRule' => 'matchGuardianRule',
        'matchTeacherRule'  => 'matchTeacherRule',
        'unionId'           => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->matchGuardianRule) {
            $res['matchGuardianRule'] = $this->matchGuardianRule;
        }
        if (null !== $this->matchTeacherRule) {
            $res['matchTeacherRule'] = $this->matchTeacherRule;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['matchGuardianRule'])) {
            $model->matchGuardianRule = $map['matchGuardianRule'];
        }
        if (isset($map['matchTeacherRule'])) {
            $model->matchTeacherRule = $map['matchTeacherRule'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
