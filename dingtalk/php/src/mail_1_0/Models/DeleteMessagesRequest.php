<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteMessagesRequest extends Model
{
    /**
     * @var string
     */
    public $deleteType;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $ids;
    protected $_name = [
        'deleteType' => 'deleteType',
        'ids' => 'ids',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deleteType) {
            $res['deleteType'] = $this->deleteType;
        }
        if (null !== $this->ids) {
            $res['ids'] = $this->ids;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteMessagesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deleteType'])) {
            $model->deleteType = $map['deleteType'];
        }
        if (isset($map['ids'])) {
            if (!empty($map['ids'])) {
                $model->ids = $map['ids'];
            }
        }

        return $model;
    }
}
