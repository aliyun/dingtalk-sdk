<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtrip_1_0\Models\SyncInvoiceEntityRequest;

use AlibabaCloud\Tea\Model;

class entityList extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $entityId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $entityType;
    protected $_name = [
        'entityId' => 'entityId',
        'entityType' => 'entityType',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return entityList
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

        return $model;
    }
}
