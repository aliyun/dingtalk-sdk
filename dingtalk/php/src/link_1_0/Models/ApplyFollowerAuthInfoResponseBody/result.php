<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\ApplyFollowerAuthInfoResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 发送申请ID
     *
     * @var string
     */
    public $openApplyId;
    protected $_name = [
        'openApplyId' => 'openApplyId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->openApplyId) {
            $res['openApplyId'] = $this->openApplyId;
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
        if (isset($map['openApplyId'])) {
            $model->openApplyId = $map['openApplyId'];
        }

        return $model;
    }
}
