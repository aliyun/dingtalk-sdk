<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdevicemng_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateDepartmentRequest extends Model
{
    /**
     * @example zhangsan/password
     *
     * @var string
     */
    public $authInfo;

    /**
     * @example Acount
     *
     * @var string
     */
    public $authType;

    /**
     * @example {"workdate":"workday"}
     *
     * @var string
     */
    public $bizExt;

    /**
     * @example 生产1组
     *
     * @var string
     */
    public $departmentName;

    /**
     * @example Primary
     *
     * @var string
     */
    public $departmentType;

    /**
     * @example 生产1组负责中控机的组装
     *
     * @var string
     */
    public $description;

    /**
     * @example https://xxx.xxx.com/manage
     *
     * @var string
     */
    public $systemUrl;

    /**
     * @example manager10
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'authInfo'       => 'authInfo',
        'authType'       => 'authType',
        'bizExt'         => 'bizExt',
        'departmentName' => 'departmentName',
        'departmentType' => 'departmentType',
        'description'    => 'description',
        'systemUrl'      => 'systemUrl',
        'userId'         => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->authInfo) {
            $res['authInfo'] = $this->authInfo;
        }
        if (null !== $this->authType) {
            $res['authType'] = $this->authType;
        }
        if (null !== $this->bizExt) {
            $res['bizExt'] = $this->bizExt;
        }
        if (null !== $this->departmentName) {
            $res['departmentName'] = $this->departmentName;
        }
        if (null !== $this->departmentType) {
            $res['departmentType'] = $this->departmentType;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->systemUrl) {
            $res['systemUrl'] = $this->systemUrl;
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
        if (isset($map['authInfo'])) {
            $model->authInfo = $map['authInfo'];
        }
        if (isset($map['authType'])) {
            $model->authType = $map['authType'];
        }
        if (isset($map['bizExt'])) {
            $model->bizExt = $map['bizExt'];
        }
        if (isset($map['departmentName'])) {
            $model->departmentName = $map['departmentName'];
        }
        if (isset($map['departmentType'])) {
            $model->departmentType = $map['departmentType'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['systemUrl'])) {
            $model->systemUrl = $map['systemUrl'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
