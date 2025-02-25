<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateSheetRequest extends Model
{
    /**
     * @var int
     */
    public $frozenColumnCount;

    /**
     * @var int
     */
    public $frozenRowCount;

    /**
     * @example sheet_name
     *
     * @var string
     */
    public $name;

    /**
     * @example visible
     *
     * @var string
     */
    public $visibility;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'frozenColumnCount' => 'frozenColumnCount',
        'frozenRowCount'    => 'frozenRowCount',
        'name'              => 'name',
        'visibility'        => 'visibility',
        'operatorId'        => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->frozenColumnCount) {
            $res['frozenColumnCount'] = $this->frozenColumnCount;
        }
        if (null !== $this->frozenRowCount) {
            $res['frozenRowCount'] = $this->frozenRowCount;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->visibility) {
            $res['visibility'] = $this->visibility;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateSheetRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['frozenColumnCount'])) {
            $model->frozenColumnCount = $map['frozenColumnCount'];
        }
        if (isset($map['frozenRowCount'])) {
            $model->frozenRowCount = $map['frozenRowCount'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['visibility'])) {
            $model->visibility = $map['visibility'];
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
