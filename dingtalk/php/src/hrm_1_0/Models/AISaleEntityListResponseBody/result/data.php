<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AISaleEntityListResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AISaleEntityListResponseBody\result\data\fieldInstances;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $entityId;

    /**
     * @var string
     */
    public $entityType;

    /**
     * @var fieldInstances[]
     */
    public $fieldInstances;
    protected $_name = [
        'entityId' => 'entityId',
        'entityType' => 'entityType',
        'fieldInstances' => 'fieldInstances',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->entityId) {
            $res['entityId'] = $this->entityId;
        }
        if (null !== $this->entityType) {
            $res['entityType'] = $this->entityType;
        }
        if (null !== $this->fieldInstances) {
            $res['fieldInstances'] = [];
            if (null !== $this->fieldInstances && \is_array($this->fieldInstances)) {
                $n = 0;
                foreach ($this->fieldInstances as $item) {
                    $res['fieldInstances'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['entityId'])) {
            $model->entityId = $map['entityId'];
        }
        if (isset($map['entityType'])) {
            $model->entityType = $map['entityType'];
        }
        if (isset($map['fieldInstances'])) {
            if (!empty($map['fieldInstances'])) {
                $model->fieldInstances = [];
                $n = 0;
                foreach ($map['fieldInstances'] as $item) {
                    $model->fieldInstances[$n++] = null !== $item ? fieldInstances::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
