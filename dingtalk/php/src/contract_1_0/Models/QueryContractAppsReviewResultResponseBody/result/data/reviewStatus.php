<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractAppsReviewResultResponseBody\result\data;

use AlibabaCloud\Tea\Model;

class reviewStatus extends Model
{
    /**
     * @var string
     */
    public $overview;

    /**
     * @var string
     */
    public $result;

    /**
     * @var string
     */
    public $rule;

    /**
     * @var string
     */
    public $stage;
    protected $_name = [
        'overview' => 'overview',
        'result' => 'result',
        'rule' => 'rule',
        'stage' => 'stage',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->overview) {
            $res['overview'] = $this->overview;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->rule) {
            $res['rule'] = $this->rule;
        }
        if (null !== $this->stage) {
            $res['stage'] = $this->stage;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return reviewStatus
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['overview'])) {
            $model->overview = $map['overview'];
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['rule'])) {
            $model->rule = $map['rule'];
        }
        if (isset($map['stage'])) {
            $model->stage = $map['stage'];
        }

        return $model;
    }
}
