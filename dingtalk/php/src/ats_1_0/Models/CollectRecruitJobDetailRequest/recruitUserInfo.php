<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models\CollectRecruitJobDetailRequest;

use AlibabaCloud\Tea\Model;

class recruitUserInfo extends Model
{
    /**
     * @description 额外信息
     *
     * @var string
     */
    public $extInfo;

    /**
     * @description 招聘员工唯一ID
     *
     * @var string
     */
    public $outUserId;

    /**
     * @description 招聘员工手机号码
     *
     * @var string
     */
    public $userMobile;

    /**
     * @description 招聘员工姓名
     *
     * @var string
     */
    public $userName;
    protected $_name = [
        'extInfo'    => 'extInfo',
        'outUserId'  => 'outUserId',
        'userMobile' => 'userMobile',
        'userName'   => 'userName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->extInfo) {
            $res['extInfo'] = $this->extInfo;
        }
        if (null !== $this->outUserId) {
            $res['outUserId'] = $this->outUserId;
        }
        if (null !== $this->userMobile) {
            $res['userMobile'] = $this->userMobile;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return recruitUserInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extInfo'])) {
            $model->extInfo = $map['extInfo'];
        }
        if (isset($map['outUserId'])) {
            $model->outUserId = $map['outUserId'];
        }
        if (isset($map['userMobile'])) {
            $model->userMobile = $map['userMobile'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
