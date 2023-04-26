<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vorg_culture_1_0\Models\QueryPointActionAutoAssignRuleResponseBody\result;

use AlibabaCloud\Tea\Model;

class queryPointRuleResponseDTOS extends Model
{
    /**
     * @example 10
     *
     * @var int
     */
    public $awardScore;

    /**
     * @example DAILY_VISIT
     *
     * @var string
     */
    public $code;

    /**
     * @example 1
     *
     * @var int
     */
    public $dayLimitTimes;

    /**
     * @example 每日访问
     *
     * @var string
     */
    public $description;

    /**
     * @example 1
     *
     * @var int
     */
    public $status;
    protected $_name = [
        'awardScore'    => 'awardScore',
        'code'          => 'code',
        'dayLimitTimes' => 'dayLimitTimes',
        'description'   => 'description',
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
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return queryPointRuleResponseDTOS
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
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
