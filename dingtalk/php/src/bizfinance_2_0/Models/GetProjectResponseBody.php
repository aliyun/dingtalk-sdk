<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetProjectResponseBody extends Model
{
    /**
     * @var string[]
     */
    public $accountantBookIdList;

    /**
     * @var string
     */
    public $code;

    /**
     * @description This parameter is required.
     *
     * @example 1631526550994
     *
     * @var int
     */
    public $createTime;

    /**
     * @description This parameter is required.
     *
     * @example aaa
     *
     * @var string
     */
    public $creator;

    /**
     * @description This parameter is required.
     *
     * @example 和外部合作
     *
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $parentCode;

    /**
     * @description This parameter is required.
     *
     * @example PROJ-XXX
     *
     * @var string
     */
    public $projectCode;

    /**
     * @description This parameter is required.
     *
     * @example 外包项目
     *
     * @var string
     */
    public $projectName;

    /**
     * @description This parameter is required.
     *
     * @example valid
     *
     * @var string
     */
    public $status;

    /**
     * @var string
     */
    public $userDefineCode;
    protected $_name = [
        'accountantBookIdList' => 'accountantBookIdList',
        'code' => 'code',
        'createTime' => 'createTime',
        'creator' => 'creator',
        'description' => 'description',
        'name' => 'name',
        'parentCode' => 'parentCode',
        'projectCode' => 'projectCode',
        'projectName' => 'projectName',
        'status' => 'status',
        'userDefineCode' => 'userDefineCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->accountantBookIdList) {
            $res['accountantBookIdList'] = $this->accountantBookIdList;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->parentCode) {
            $res['parentCode'] = $this->parentCode;
        }
        if (null !== $this->projectCode) {
            $res['projectCode'] = $this->projectCode;
        }
        if (null !== $this->projectName) {
            $res['projectName'] = $this->projectName;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->userDefineCode) {
            $res['userDefineCode'] = $this->userDefineCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetProjectResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['accountantBookIdList'])) {
            if (!empty($map['accountantBookIdList'])) {
                $model->accountantBookIdList = $map['accountantBookIdList'];
            }
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['parentCode'])) {
            $model->parentCode = $map['parentCode'];
        }
        if (isset($map['projectCode'])) {
            $model->projectCode = $map['projectCode'];
        }
        if (isset($map['projectName'])) {
            $model->projectName = $map['projectName'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['userDefineCode'])) {
            $model->userDefineCode = $map['userDefineCode'];
        }

        return $model;
    }
}
