<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\EsignQueryApprovalInfoResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 202311081619000455501
     *
     * @var string
     */
    public $bpmsProcessBusinessId;

    /**
     * @example O6wNhB4wTMajvNW8Dc_Rjg09301699431585
     *
     * @var string
     */
    public $bpmsProcessInstanceId;

    /**
     * @example https://aflow.dingtalk.com/dingtalk/pc/query/pchomepage.htm?corpid=ding6c3948a9e37c439c35c2f4657eb6378f&swfrom=https://n.dingtalk.com/dingding/h5-contract/contractPC/index.html#/approval?procInstId=O6wNhB4wTMajvNW8Dc_Rjg09301699431585
     *
     * @var string
     */
    public $bpmsProcessInstanceUrl;
    protected $_name = [
        'bpmsProcessBusinessId' => 'bpmsProcessBusinessId',
        'bpmsProcessInstanceId' => 'bpmsProcessInstanceId',
        'bpmsProcessInstanceUrl' => 'bpmsProcessInstanceUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bpmsProcessBusinessId) {
            $res['bpmsProcessBusinessId'] = $this->bpmsProcessBusinessId;
        }
        if (null !== $this->bpmsProcessInstanceId) {
            $res['bpmsProcessInstanceId'] = $this->bpmsProcessInstanceId;
        }
        if (null !== $this->bpmsProcessInstanceUrl) {
            $res['bpmsProcessInstanceUrl'] = $this->bpmsProcessInstanceUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bpmsProcessBusinessId'])) {
            $model->bpmsProcessBusinessId = $map['bpmsProcessBusinessId'];
        }
        if (isset($map['bpmsProcessInstanceId'])) {
            $model->bpmsProcessInstanceId = $map['bpmsProcessInstanceId'];
        }
        if (isset($map['bpmsProcessInstanceUrl'])) {
            $model->bpmsProcessInstanceUrl = $map['bpmsProcessInstanceUrl'];
        }

        return $model;
    }
}
