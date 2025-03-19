<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ShiftAddRequest\setting;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\ShiftAddRequest\setting\lateBackSetting\sections;
use AlibabaCloud\Tea\Model;

class lateBackSetting extends Model
{
    /**
     * @var bool
     */
    public $enable;

    /**
     * @var sections[]
     */
    public $sections;
    protected $_name = [
        'enable' => 'enable',
        'sections' => 'sections',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->enable) {
            $res['enable'] = $this->enable;
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return lateBackSetting
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['enable'])) {
            $model->enable = $map['enable'];
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

        return $model;
    }
}
