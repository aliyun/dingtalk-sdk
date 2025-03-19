<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetAllAuthCubesResponseBody\result;

use AlibabaCloud\Tea\Model;

class userInformation extends Model
{
    /**
     * @var string
     */
    public $authProvider;

    /**
     * @example ding5d17e3add038d44535c2f4657eb6378e
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 开发部
     *
     * @var string
     */
    public $departmentName;

    /**
     * @example 测试应用
     *
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $nickName;

    /**
     * @var int
     */
    public $realmId;

    /**
     * @var string
     */
    public $refererNamespaceCode;

    /**
     * @example 请购类型
     *
     * @var string
     */
    public $showName;

    /**
     * @var string
     */
    public $workNo;
    protected $_name = [
        'authProvider' => 'authProvider',
        'corpId' => 'corpId',
        'departmentName' => 'departmentName',
        'name' => 'name',
        'nickName' => 'nickName',
        'realmId' => 'realmId',
        'refererNamespaceCode' => 'refererNamespaceCode',
        'showName' => 'showName',
        'workNo' => 'workNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->authProvider) {
            $res['authProvider'] = $this->authProvider;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->departmentName) {
            $res['departmentName'] = $this->departmentName;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nickName) {
            $res['nickName'] = $this->nickName;
        }
        if (null !== $this->realmId) {
            $res['realmId'] = $this->realmId;
        }
        if (null !== $this->refererNamespaceCode) {
            $res['refererNamespaceCode'] = $this->refererNamespaceCode;
        }
        if (null !== $this->showName) {
            $res['showName'] = $this->showName;
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return userInformation
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['authProvider'])) {
            $model->authProvider = $map['authProvider'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['departmentName'])) {
            $model->departmentName = $map['departmentName'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nickName'])) {
            $model->nickName = $map['nickName'];
        }
        if (isset($map['realmId'])) {
            $model->realmId = $map['realmId'];
        }
        if (isset($map['refererNamespaceCode'])) {
            $model->refererNamespaceCode = $map['refererNamespaceCode'];
        }
        if (isset($map['showName'])) {
            $model->showName = $map['showName'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
