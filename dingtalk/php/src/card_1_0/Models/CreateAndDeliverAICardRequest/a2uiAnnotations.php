<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\CreateAndDeliverAICardRequest;

use AlibabaCloud\Tea\Model;

class a2uiAnnotations extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $componentId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $surfaceId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'componentId' => 'componentId',
        'surfaceId' => 'surfaceId',
        'type' => 'type',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->componentId) {
            $res['componentId'] = $this->componentId;
        }
        if (null !== $this->surfaceId) {
            $res['surfaceId'] = $this->surfaceId;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return a2uiAnnotations
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['componentId'])) {
            $model->componentId = $map['componentId'];
        }
        if (isset($map['surfaceId'])) {
            $model->surfaceId = $map['surfaceId'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
