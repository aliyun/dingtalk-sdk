<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceCustomTemplateResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vrooms_1_0\Models\QueryDeviceCustomTemplateResponseBody\result\deviceCustomTemplate;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var deviceCustomTemplate
     */
    public $deviceCustomTemplate;

    /**
     * @var string[]
     */
    public $deviceUnionIds;

    /**
     * @var int[]
     */
    public $groupIds;

    /**
     * @var string[]
     */
    public $roomIds;
    protected $_name = [
        'deviceCustomTemplate' => 'deviceCustomTemplate',
        'deviceUnionIds'       => 'deviceUnionIds',
        'groupIds'             => 'groupIds',
        'roomIds'              => 'roomIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deviceCustomTemplate) {
            $res['deviceCustomTemplate'] = null !== $this->deviceCustomTemplate ? $this->deviceCustomTemplate->toMap() : null;
        }
        if (null !== $this->deviceUnionIds) {
            $res['deviceUnionIds'] = $this->deviceUnionIds;
        }
        if (null !== $this->groupIds) {
            $res['groupIds'] = $this->groupIds;
        }
        if (null !== $this->roomIds) {
            $res['roomIds'] = $this->roomIds;
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
        if (isset($map['deviceCustomTemplate'])) {
            $model->deviceCustomTemplate = deviceCustomTemplate::fromMap($map['deviceCustomTemplate']);
        }
        if (isset($map['deviceUnionIds'])) {
            if (!empty($map['deviceUnionIds'])) {
                $model->deviceUnionIds = $map['deviceUnionIds'];
            }
        }
        if (isset($map['groupIds'])) {
            if (!empty($map['groupIds'])) {
                $model->groupIds = $map['groupIds'];
            }
        }
        if (isset($map['roomIds'])) {
            if (!empty($map['roomIds'])) {
                $model->roomIds = $map['roomIds'];
            }
        }

        return $model;
    }
}
