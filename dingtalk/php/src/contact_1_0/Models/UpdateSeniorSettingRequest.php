<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateSeniorSettingRequest extends Model
{
    /**
     * @var string
     */
    public $seniorStaffId;

    /**
     * @var bool
     */
    public $open;

    /**
     * @var string[]
     */
    public $permitStaffIds;

    /**
     * @var int[]
     */
    public $permitDeptIds;

    /**
     * @var int[]
     */
    public $permitTagIds;

    /**
     * @var string[]
     */
    public $protectScenes;
    protected $_name = [
        'seniorStaffId'  => 'seniorStaffId',
        'open'           => 'open',
        'permitStaffIds' => 'permitStaffIds',
        'permitDeptIds'  => 'permitDeptIds',
        'permitTagIds'   => 'permitTagIds',
        'protectScenes'  => 'protectScenes',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->seniorStaffId) {
            $res['seniorStaffId'] = $this->seniorStaffId;
        }
        if (null !== $this->open) {
            $res['open'] = $this->open;
        }
        if (null !== $this->permitStaffIds) {
            $res['permitStaffIds'] = $this->permitStaffIds;
        }
        if (null !== $this->permitDeptIds) {
            $res['permitDeptIds'] = $this->permitDeptIds;
        }
        if (null !== $this->permitTagIds) {
            $res['permitTagIds'] = $this->permitTagIds;
        }
        if (null !== $this->protectScenes) {
            $res['protectScenes'] = $this->protectScenes;
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
        if (isset($map['seniorStaffId'])) {
            $model->seniorStaffId = $map['seniorStaffId'];
        }
        if (isset($map['open'])) {
            $model->open = $map['open'];
        }
        if (isset($map['permitStaffIds'])) {
            if (!empty($map['permitStaffIds'])) {
                $model->permitStaffIds = $map['permitStaffIds'];
            }
        }
        if (isset($map['permitDeptIds'])) {
            if (!empty($map['permitDeptIds'])) {
                $model->permitDeptIds = $map['permitDeptIds'];
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

        return $model;
    }
}
