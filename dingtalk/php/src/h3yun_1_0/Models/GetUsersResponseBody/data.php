<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vh3yun_1_0\Models\GetUsersResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example zhangsan
     *
     * @var string
     */
    public $code;

    /**
     * @example 18f923a7-5a5e-426d-94ae-a55ad1a4b240
     *
     * @var string
     */
    public $departmentId;

    /**
     * @example 研发中心
     *
     * @var string
     */
    public $departmentName;

    /**
     * @example Null
     *
     * @var string
     */
    public $description;

    /**
     * @example Internal
     *
     * @var string
     */
    public $domainType;

    /**
     * @example zhangsan@example.com
     *
     * @var string
     */
    public $email;

    /**
     * @example 018bbb56-a9dd-49a1-8495-129c6b0d95c5
     *
     * @var string
     */
    public $id;

    /**
     * @example 156********
     *
     * @var string
     */
    public $mobile;

    /**
     * @example 张三
     *
     * @var string
     */
    public $name;

    /**
     * @var string[]
     */
    public $partDepartmentIds;

    /**
     * @example Man
     *
     * @var string
     */
    public $sex;

    /**
     * @example 176294501822126512
     *
     * @var int
     */
    public $sortKey;
    protected $_name = [
        'code'              => 'code',
        'departmentId'      => 'departmentId',
        'departmentName'    => 'departmentName',
        'description'       => 'description',
        'domainType'        => 'domainType',
        'email'             => 'email',
        'id'                => 'id',
        'mobile'            => 'mobile',
        'name'              => 'name',
        'partDepartmentIds' => 'partDepartmentIds',
        'sex'               => 'sex',
        'sortKey'           => 'sortKey',
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
        if (null !== $this->id) {
            $res['id'] = $this->id;
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
        if (isset($map['id'])) {
            $model->id = $map['id'];
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

        return $model;
    }
}
