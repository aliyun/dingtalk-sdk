<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CommitFileResponseBody\dentry;
use AlibabaCloud\Tea\Model;

class CommitFileResponseBody extends Model
{
    /**
     * @var dentry
     */
    public $dentry;
    protected $_name = [
        'dentry' => 'dentry',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dentry) {
            $res['dentry'] = null !== $this->dentry ? $this->dentry->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CommitFileResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dentry'])) {
            $model->dentry = dentry::fromMap($map['dentry']);
        }

        return $model;
    }
}
