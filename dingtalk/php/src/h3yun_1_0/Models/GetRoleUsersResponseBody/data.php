<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetRoleUsersResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description 用户编码
     *
     * @var string
     */
    public $code;

    /**
     * @description 所属部门id
     *
     * @var string
     */
    public $departmentId;

    /**
     * @description 所属部门名称
     *
     * @var string
     */
    public $departmentName;

    /**
     * @description 描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 所属范围。Internal=内部，External=外部
     *
     * @var string
     */
    public $domainType;

    /**
     * @description 邮箱
     *
     * @var string
     */
    public $email;

    /**
     * @description 手机号码
     *
     * @var string
     */
    public $mobile;

    /**
     * @description 用户名称
     *
     * @var string
     */
    public $name;

    /**
     * @description 兼职部门id集合（含主部门id）
     *
     * @var string[]
     */
    public $partDepartmentIds;

    /**
     * @description 性别.None=未指定，Man=男性，Female=女性
     *
     * @var string
     */
    public $sex;

    /**
     * @description 排序值
     *
     * @var int
     */
    public $sortKey;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'code'              => 'code',
        'departmentId'      => 'departmentId',
        'departmentName'    => 'departmentName',
        'description'       => 'description',
        'domainType'        => 'domainType',
        'email'             => 'email',
        'mobile'            => 'mobile',
        'name'              => 'name',
        'partDepartmentIds' => 'partDepartmentIds',
        'sex'               => 'sex',
        'sortKey'           => 'sortKey',
        'userId'            => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }
        if (null !== $this->departmentName) {
            $res['departmentName'] = $this->departmentName;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->domainType) {
            $res['domainType'] = $this->domainType;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->partDepartmentIds) {
            $res['partDepartmentIds'] = $this->partDepartmentIds;
        }
        if (null !== $this->sex) {
            $res['sex'] = $this->sex;
        }
        if (null !== $this->sortKey) {
            $res['sortKey'] = $this->sortKey;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['departmentName'])) {
            $model->departmentName = $map['departmentName'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['domainType'])) {
            $model->domainType = $map['domainType'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['partDepartmentIds'])) {
            if (!empty($map['partDepartmentIds'])) {
                $model->partDepartmentIds = $map['partDepartmentIds'];
            }
        }
        if (isset($map['sex'])) {
            $model->sex = $map['sex'];
        }
        if (isset($map['sortKey'])) {
            $model->sortKey = $map['sortKey'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
