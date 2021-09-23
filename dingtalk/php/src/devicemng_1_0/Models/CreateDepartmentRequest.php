<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateDepartmentRequest extends Model
{
    /**
     * @description 组织id
     *
     * @var string
     */
    public $dingCorpId;

    /**
     * @description 部门名称
     *
     * @var string
     */
    public $departmentName;

    /**
     * @description 部门类型
     *
     * @var string
     */
    public $departmentType;

    /**
     * @description 业务系统地址
     *
     * @var string
     */
    public $systemUrl;

    /**
     * @description 认证方式
     *
     * @var string
     */
    public $authType;

    /**
     * @description 认证信息
     *
     * @var string
     */
    public $authInfo;

    /**
     * @description 部门描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 业务扩展
     *
     * @var string
     */
    public $bizExt;

    /**
     * @description 创建人工号
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'dingCorpId'     => 'dingCorpId',
        'departmentName' => 'departmentName',
        'departmentType' => 'departmentType',
        'systemUrl'      => 'systemUrl',
        'authType'       => 'authType',
        'authInfo'       => 'authInfo',
        'description'    => 'description',
        'bizExt'         => 'bizExt',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->departmentName) {
            $res['departmentName'] = $this->departmentName;
        }
        if (null !== $this->departmentType) {
            $res['departmentType'] = $this->departmentType;
        }
        if (null !== $this->systemUrl) {
            $res['systemUrl'] = $this->systemUrl;
        }
        if (null !== $this->authType) {
            $res['authType'] = $this->authType;
        }
        if (null !== $this->authInfo) {
            $res['authInfo'] = $this->authInfo;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->bizExt) {
            $res['bizExt'] = $this->bizExt;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateDepartmentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['departmentName'])) {
            $model->departmentName = $map['departmentName'];
        }
        if (isset($map['departmentType'])) {
            $model->departmentType = $map['departmentType'];
        }
        if (isset($map['systemUrl'])) {
            $model->systemUrl = $map['systemUrl'];
        }
        if (isset($map['authType'])) {
            $model->authType = $map['authType'];
        }
        if (isset($map['authInfo'])) {
            $model->authInfo = $map['authInfo'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['bizExt'])) {
            $model->bizExt = $map['bizExt'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
