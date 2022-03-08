<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest;

use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\courseInfo\lectorUserInfo;
use AlibabaCloud\SDK\Dingtalk\Vcontent_1_0\Models\CreateFeedRequest\courseInfo\payInfo;
use AlibabaCloud\Tea\Model;

class courseInfo extends Model
{
    /**
     * @description 讲师身份信息
     *
     * @var lectorUserInfo
     */
    public $lectorUserInfo;

    /**
     * @description 支付信息
     *
     * @var payInfo
     */
    public $payInfo;

    /**
     * @description 创建一个和该课程绑定的学习群和圈子
     *
     * @var string
     */
    public $studyGroupName;
    protected $_name = [
        'lectorUserInfo' => 'lectorUserInfo',
        'payInfo'        => 'payInfo',
        'studyGroupName' => 'studyGroupName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->lectorUserInfo) {
            $res['lectorUserInfo'] = null !== $this->lectorUserInfo ? $this->lectorUserInfo->toMap() : null;
        }
        if (null !== $this->payInfo) {
            $res['payInfo'] = null !== $this->payInfo ? $this->payInfo->toMap() : null;
        }
        if (null !== $this->studyGroupName) {
            $res['studyGroupName'] = $this->studyGroupName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return courseInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['lectorUserInfo'])) {
            $model->lectorUserInfo = lectorUserInfo::fromMap($map['lectorUserInfo']);
        }
        if (isset($map['payInfo'])) {
            $model->payInfo = payInfo::fromMap($map['payInfo']);
        }
        if (isset($map['studyGroupName'])) {
            $model->studyGroupName = $map['studyGroupName'];
        }

        return $model;
    }
}
