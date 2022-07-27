<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddFolderResponseBody\dentry;
use AlibabaCloud\Tea\Model;

class AddFolderResponseBody extends Model
{
    /**
     * @description 文件夹信息
     * dentry.type等于FOLDER表示是文件夹
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
     * @return AddFolderResponseBody
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
