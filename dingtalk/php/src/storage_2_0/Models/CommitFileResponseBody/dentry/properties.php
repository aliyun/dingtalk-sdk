<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\CommitFileResponseBody\dentry;

use AlibabaCloud\Tea\Model;

class properties extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $readOnly;
    protected $_name = [
        'readOnly' => 'readOnly',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->readOnly) {
            $res['readOnly'] = $this->readOnly;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return properties
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['readOnly'])) {
            $model->readOnly = $map['readOnly'];
        }

        return $model;
    }
}
