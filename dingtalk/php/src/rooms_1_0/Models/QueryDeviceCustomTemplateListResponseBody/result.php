<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceCustomTemplateListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceCustomTemplateListResponseBody\result\deviceCustomTemplates;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var deviceCustomTemplates[]
     */
    public $deviceCustomTemplates;

    /**
     * @var string[][]
     */
    public $deviceTemplateMap;

    /**
     * @var int[][]
     */
    public $groupIdTemplateMap;

    /**
     * @var string[][]
     */
    public $roomIdTemplateMap;
    protected $_name = [
        'deviceCustomTemplates' => 'deviceCustomTemplates',
        'deviceTemplateMap'     => 'deviceTemplateMap',
        'groupIdTemplateMap'    => 'groupIdTemplateMap',
        'roomIdTemplateMap'     => 'roomIdTemplateMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceCustomTemplates) {
            $res['deviceCustomTemplates'] = [];
            if (null !== $this->deviceCustomTemplates && \is_array($this->deviceCustomTemplates)) {
                $n = 0;
                foreach ($this->deviceCustomTemplates as $item) {
                    $res['deviceCustomTemplates'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->deviceTemplateMap) {
            $res['deviceTemplateMap'] = $this->deviceTemplateMap;
        }
        if (null !== $this->groupIdTemplateMap) {
            $res['groupIdTemplateMap'] = $this->groupIdTemplateMap;
        }
        if (null !== $this->roomIdTemplateMap) {
            $res['roomIdTemplateMap'] = $this->roomIdTemplateMap;
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
        if (isset($map['deviceCustomTemplates'])) {
            if (!empty($map['deviceCustomTemplates'])) {
                $model->deviceCustomTemplates = [];
                $n                            = 0;
                foreach ($map['deviceCustomTemplates'] as $item) {
                    $model->deviceCustomTemplates[$n++] = null !== $item ? deviceCustomTemplates::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['deviceTemplateMap'])) {
            $model->deviceTemplateMap = $map['deviceTemplateMap'];
        }
        if (isset($map['groupIdTemplateMap'])) {
            $model->groupIdTemplateMap = $map['groupIdTemplateMap'];
        }
        if (isset($map['roomIdTemplateMap'])) {
            $model->roomIdTemplateMap = $map['roomIdTemplateMap'];
        }

        return $model;
    }
}
