<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftResponseBody\result\sections;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftResponseBody\result\shiftSetting;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example dinge87f1xxxx
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 678215070
     *
     * @var int
     */
    public $id;

    /**
     * @example B
     *
     * @var string
     */
    public $name;

    /**
     * @example user123
     *
     * @var string
     */
    public $owner;

    /**
     * @var sections[]
     */
    public $sections;

    /**
     * @var int
     */
    public $shiftGroupId;

    /**
     * @example 考勤班
     *
     * @var string
     */
    public $shiftGroupName;

    /**
     * @var shiftSetting
     */
    public $shiftSetting;
    protected $_name = [
        'corpId' => 'corpId',
        'id' => 'id',
        'name' => 'name',
        'owner' => 'owner',
        'sections' => 'sections',
        'shiftGroupId' => 'shiftGroupId',
        'shiftGroupName' => 'shiftGroupName',
        'shiftSetting' => 'shiftSetting',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
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
        if (null !== $this->shiftGroupId) {
            $res['shiftGroupId'] = $this->shiftGroupId;
        }
        if (null !== $this->shiftGroupName) {
            $res['shiftGroupName'] = $this->shiftGroupName;
        }
        if (null !== $this->shiftSetting) {
            $res['shiftSetting'] = null !== $this->shiftSetting ? $this->shiftSetting->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
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
        if (isset($map['shiftGroupId'])) {
            $model->shiftGroupId = $map['shiftGroupId'];
        }
        if (isset($map['shiftGroupName'])) {
            $model->shiftGroupName = $map['shiftGroupName'];
        }
        if (isset($map['shiftSetting'])) {
            $model->shiftSetting = shiftSetting::fromMap($map['shiftSetting']);
        }

        return $model;
    }
}
