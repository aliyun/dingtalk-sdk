<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ShiftAddRequest\sections;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ShiftAddRequest\setting;
use AlibabaCloud\Tea\Model;

class ShiftAddRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 白班
     *
     * @var string
     */
    public $name;

    /**
     * @example user01
     *
     * @var string
     */
    public $owner;

    /**
     * @description This parameter is required.
     *
     * @var sections[]
     */
    public $sections;

    /**
     * @example 123
     *
     * @var int
     */
    public $serviceId;

    /**
     * @var setting
     */
    public $setting;

    /**
     * @example 1234
     *
     * @var int
     */
    public $shiftId;

    /**
     * @description This parameter is required.
     *
     * @example user01
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'name' => 'name',
        'owner' => 'owner',
        'sections' => 'sections',
        'serviceId' => 'serviceId',
        'setting' => 'setting',
        'shiftId' => 'shiftId',
        'opUserId' => 'opUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->owner) {
            $res['owner'] = $this->owner;
        }
        if (null !== $this->sections) {
            $res['sections'] = [];
            if (null !== $this->sections && \is_array($this->sections)) {
                $n = 0;
                foreach ($this->sections as $item) {
                    $res['sections'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->serviceId) {
            $res['serviceId'] = $this->serviceId;
        }
        if (null !== $this->setting) {
            $res['setting'] = null !== $this->setting ? $this->setting->toMap() : null;
        }
        if (null !== $this->shiftId) {
            $res['shiftId'] = $this->shiftId;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ShiftAddRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['owner'])) {
            $model->owner = $map['owner'];
        }
        if (isset($map['sections'])) {
            if (!empty($map['sections'])) {
                $model->sections = [];
                $n = 0;
                foreach ($map['sections'] as $item) {
                    $model->sections[$n++] = null !== $item ? sections::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['serviceId'])) {
            $model->serviceId = $map['serviceId'];
        }
        if (isset($map['setting'])) {
            $model->setting = setting::fromMap($map['setting']);
        }
        if (isset($map['shiftId'])) {
            $model->shiftId = $map['shiftId'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
