<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryProjectByPageResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description 项目code
     *
     * @var string
     */
    public $caode;

    /**
     * @description 创建时间
     *
     * @var int
     */
    public $createTime;

    /**
     * @description 创建人工号
     *
     * @var string
     */
    public $creator;

    /**
     * @description 描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 项目名字
     *
     * @var string
     */
    public $name;

    /**
     * @description 项目code，废弃，请使用code
     *
     * @var string
     */
    public $projectCode;

    /**
     * @description 项目名称，废弃，请使用name
     *
     * @var string
     */
    public $projectName;

    /**
     * @description 状态: valid, invalid, deleted
     *
     * @var string
     */
    public $status;

    /**
     * @description 用户自定义code
     *
     * @var string
     */
    public $userDefineCode;
    protected $_name = [
        'caode'          => 'caode',
        'createTime'     => 'createTime',
        'creator'        => 'creator',
        'description'    => 'description',
        'name'           => 'name',
        'projectCode'    => 'projectCode',
        'projectName'    => 'projectName',
        'status'         => 'status',
        'userDefineCode' => 'userDefineCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->caode) {
            $res['caode'] = $this->caode;
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
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['caode'])) {
            $model->caode = $map['caode'];
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
