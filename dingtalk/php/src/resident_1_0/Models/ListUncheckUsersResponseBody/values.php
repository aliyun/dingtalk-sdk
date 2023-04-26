<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models\ListUncheckUsersResponseBody;

use AlibabaCloud\Tea\Model;

class values extends Model
{
    /**
     * @example 5345345
     *
     * @var int
     */
    public $deptId;

    /**
     * @example "{\"startTime\":\"1654746593623\",\"endTime\":\"1656042593623\"}"
     *
     * @var string
     */
    public $extension;

    /**
     * @example 1652683318162
     *
     * @var int
     */
    public $gmtCreate;

    /**
     * @example 1652683318162
     *
     * @var int
     */
    public $gmtModified;

    /**
     * @example true
     *
     * @var bool
     */
    public $isPropertyOwner;

    /**
     * @example 张工
     *
     * @var string
     */
    public $name;

    /**
     * @example 1
     *
     * @var int
     */
    public $status;

    /**
     * @example 312423423
     *
     * @var int
     */
    public $unionId;
    protected $_name = [
        'deptId'          => 'deptId',
        'extension'       => 'extension',
        'gmtCreate'       => 'gmtCreate',
        'gmtModified'     => 'gmtModified',
        'isPropertyOwner' => 'isPropertyOwner',
        'name'            => 'name',
        'status'          => 'status',
        'unionId'         => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->isPropertyOwner) {
            $res['isPropertyOwner'] = $this->isPropertyOwner;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return values
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['isPropertyOwner'])) {
            $model->isPropertyOwner = $map['isPropertyOwner'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
