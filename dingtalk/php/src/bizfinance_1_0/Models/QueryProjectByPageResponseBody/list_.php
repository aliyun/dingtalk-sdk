<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_1_0\Models\QueryProjectByPageResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $caode;

    /**
     * @example 1631524595555
     *
     * @var int
     */
    public $createTime;

    /**
     * @example aaaa
     *
     * @var string
     */
    public $creator;

    /**
     * @example 外派项目
     *
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $name;

    /**
     * @example PROJ-xxx
     *
     * @var string
     */
    public $projectCode;

    /**
     * @example 外派项目
     *
     * @var string
     */
    public $projectName;

    /**
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
