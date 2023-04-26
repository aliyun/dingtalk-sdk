<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\Tea\Model;

class RenameDentryRequest extends Model
{
    /**
     * @example dentry_name
     *
     * @var string
     */
    public $newName;

    /**
     * @example union_id
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'newName' => 'newName',
        'unionId' => 'unionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->newName) {
            $res['newName'] = $this->newName;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RenameDentryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['newName'])) {
            $model->newName = $map['newName'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
