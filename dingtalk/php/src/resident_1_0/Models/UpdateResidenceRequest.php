<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateResidenceRequest extends Model
{
    /**
     * @example 12345
     *
     * @var int
     */
    public $departmentId;

    /**
     * @example 101户
     *
     * @var string
     */
    public $departmentName;

    /**
     * @example false
     *
     * @var bool
     */
    public $destitute;

    /**
     * @example 第1网格
     *
     * @var string
     */
    public $grid;

    /**
     * @example 16612345678
     *
     * @var string
     */
    public $homeTel;

    /**
     * @example 1234
     *
     * @var string
     */
    public $managerUserId;

    /**
     * @example 12345
     *
     * @var int
     */
    public $parentDepartmentId;
    protected $_name = [
        'departmentId'       => 'departmentId',
        'departmentName'     => 'departmentName',
        'destitute'          => 'destitute',
        'grid'               => 'grid',
        'homeTel'            => 'homeTel',
        'managerUserId'      => 'managerUserId',
        'parentDepartmentId' => 'parentDepartmentId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }
        if (null !== $this->departmentName) {
            $res['departmentName'] = $this->departmentName;
        }
        if (null !== $this->destitute) {
            $res['destitute'] = $this->destitute;
        }
        if (null !== $this->grid) {
            $res['grid'] = $this->grid;
        }
        if (null !== $this->homeTel) {
            $res['homeTel'] = $this->homeTel;
        }
        if (null !== $this->managerUserId) {
            $res['managerUserId'] = $this->managerUserId;
        }
        if (null !== $this->parentDepartmentId) {
            $res['parentDepartmentId'] = $this->parentDepartmentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateResidenceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }
        if (isset($map['departmentName'])) {
            $model->departmentName = $map['departmentName'];
        }
        if (isset($map['destitute'])) {
            $model->destitute = $map['destitute'];
        }
        if (isset($map['grid'])) {
            $model->grid = $map['grid'];
        }
        if (isset($map['homeTel'])) {
            $model->homeTel = $map['homeTel'];
        }
        if (isset($map['managerUserId'])) {
            $model->managerUserId = $map['managerUserId'];
        }
        if (isset($map['parentDepartmentId'])) {
            $model->parentDepartmentId = $map['parentDepartmentId'];
        }

        return $model;
    }
}
