<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vconv_file_1_0\Models\SendLinkResponseBody\file;
use AlibabaCloud\Tea\Model;

class SendLinkResponseBody extends Model
{
    /**
     * @description 发送到目标会话的文件链接信息
     *
     * @var file
     */
    public $file;
    protected $_name = [
        'file' => 'file',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->file) {
            $res['file'] = null !== $this->file ? $this->file->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendLinkResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['file'])) {
            $model->file = file::fromMap($map['file']);
        }

        return $model;
    }
}
