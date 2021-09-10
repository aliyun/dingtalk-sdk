<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetTrainExceedApplyRequest extends Model
{
    /**
     * @description 第三方企业id
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 商旅超标审批单id
     *
     * @var string
     */
    public $applyId;
    protected $_name = [
        'corpId'  => 'corpId',
        'applyId' => 'applyId',
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
        if (null !== $this->applyId) {
            $res['applyId'] = $this->applyId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetTrainExceedApplyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['applyId'])) {
            $model->applyId = $map['applyId'];
        }

        return $model;
    }
}
