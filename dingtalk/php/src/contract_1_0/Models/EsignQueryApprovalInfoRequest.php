<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class EsignQueryApprovalInfoRequest extends Model
{
    /**
     * @example dingd0c871e2dfc941a34ac5d6980864d335
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 5556ae0359c64c4b9491c0c3c339341f
     *
     * @var string
     */
    public $esignFlowId;

    /**
     * @example PbnhW6rVXRg8u6T4NiiOwwQiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'corpId'      => 'corpId',
        'esignFlowId' => 'esignFlowId',
        'unionId'     => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->esignFlowId) {
            $res['esignFlowId'] = $this->esignFlowId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return EsignQueryApprovalInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['esignFlowId'])) {
            $model->esignFlowId = $map['esignFlowId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
