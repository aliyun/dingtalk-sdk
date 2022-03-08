<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetOfficialAccountContactInfoResponseBody extends Model
{
    /**
     * @description 已授权的字段
     *
     * @var string[]
     */
    public $authItems;

    /**
     * @description 联系人主企业名称
     *
     * @var string
     */
    public $corpName;

    /**
     * @description 手机号
     *
     * @var string
     */
    public $mobile;

    /**
     * @description 手机号国家码
     *
     * @var string
     */
    public $stateCode;

    /**
     * @description 联系人的unionId
     *
     * @var string
     */
    public $unionId;

    /**
     * @description 已授权的字段
     *
     * @var string[]
     */
    public $userInfos;
    protected $_name = [
        'authItems' => 'authItems',
        'corpName'  => 'corpName',
        'mobile'    => 'mobile',
        'stateCode' => 'stateCode',
        'unionId'   => 'unionId',
        'userInfos' => 'userInfos',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authItems) {
            $res['authItems'] = $this->authItems;
        }
        if (null !== $this->corpName) {
            $res['corpName'] = $this->corpName;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->stateCode) {
            $res['stateCode'] = $this->stateCode;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userInfos) {
            $res['userInfos'] = $this->userInfos;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetOfficialAccountContactInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authItems'])) {
            if (!empty($map['authItems'])) {
                $model->authItems = $map['authItems'];
            }
        }
        if (isset($map['corpName'])) {
            $model->corpName = $map['corpName'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['stateCode'])) {
            $model->stateCode = $map['stateCode'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userInfos'])) {
            if (!empty($map['userInfos'])) {
                $model->userInfos = $map['userInfos'];
            }
        }

        return $model;
    }
}
