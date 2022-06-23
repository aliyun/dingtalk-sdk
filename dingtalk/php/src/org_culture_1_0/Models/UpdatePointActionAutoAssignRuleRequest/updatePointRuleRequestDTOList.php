<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\UpdatePointActionAutoAssignRuleRequest;

use AlibabaCloud\Tea\Model;

class updatePointRuleRequestDTOList extends Model
{
    /**
     * @description 奖励积分1～100
     *
     * @var int
     */
    public $awardScore;

    /**
     * @description 行为名称 不支持修改
     *
     * @var string
     */
    public $code;

    /**
     * @description 单日计次上限 1～10
     *
     * @var int
     */
    public $dayLimitTimes;

    /**
     * @description 生效状态：0无效，1有效
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'awardScore'    => 'awardScore',
        'code'          => 'code',
        'dayLimitTimes' => 'dayLimitTimes',
        'status'        => 'status',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->awardScore) {
            $res['awardScore'] = $this->awardScore;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->dayLimitTimes) {
            $res['dayLimitTimes'] = $this->dayLimitTimes;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return updatePointRuleRequestDTOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['awardScore'])) {
            $model->awardScore = $map['awardScore'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['dayLimitTimes'])) {
            $model->dayLimitTimes = $map['dayLimitTimes'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
