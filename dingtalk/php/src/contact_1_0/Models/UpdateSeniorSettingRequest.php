<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateSeniorSettingRequest extends Model
{
    /**
     * @var bool
     */
    public $open;

    /**
     * @var int[]
     */
    public $permitDeptIds;

    /**
     * @var string[]
     */
    public $permitStaffIds;

    /**
     * @var int[]
     */
    public $permitTagIds;

    /**
     * @var string[]
     */
    public $protectScenes;

    /**
     * @var string
     */
    public $seniorStaffId;
    protected $_name = [
        'open'           => 'open',
        'permitDeptIds'  => 'permitDeptIds',
        'permitStaffIds' => 'permitStaffIds',
        'permitTagIds'   => 'permitTagIds',
        'protectScenes'  => 'protectScenes',
        'seniorStaffId'  => 'seniorStaffId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->open) {
            $res['open'] = $this->open;
        }
        if (null !== $this->permitDeptIds) {
            $res['permitDeptIds'] = $this->permitDeptIds;
        }
        if (null !== $this->permitStaffIds) {
            $res['permitStaffIds'] = $this->permitStaffIds;
        }
        if (null !== $this->permitTagIds) {
            $res['permitTagIds'] = $this->permitTagIds;
        }
        if (null !== $this->protectScenes) {
            $res['protectScenes'] = $this->protectScenes;
        }
        if (null !== $this->seniorStaffId) {
            $res['seniorStaffId'] = $this->seniorStaffId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateSeniorSettingRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['open'])) {
            $model->open = $map['open'];
        }
        if (isset($map['permitDeptIds'])) {
            if (!empty($map['permitDeptIds'])) {
                $model->permitDeptIds = $map['permitDeptIds'];
            }
        }
        if (isset($map['permitStaffIds'])) {
            if (!empty($map['permitStaffIds'])) {
                $model->permitStaffIds = $map['permitStaffIds'];
            }
        }
        if (isset($map['permitTagIds'])) {
            if (!empty($map['permitTagIds'])) {
                $model->permitTagIds = $map['permitTagIds'];
            }
        }
        if (isset($map['protectScenes'])) {
            if (!empty($map['protectScenes'])) {
                $model->protectScenes = $map['protectScenes'];
            }
        }
        if (isset($map['seniorStaffId'])) {
            $model->seniorStaffId = $map['seniorStaffId'];
        }

        return $model;
    }
}
