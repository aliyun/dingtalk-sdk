<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\CopyFileResponseBody\file;
use AlibabaCloud\Tea\Model;

class CopyFileResponseBody extends Model
{
    /**
     * @description 文件信息
     *
     * @var file
     */
    public $file;

    /**
     * @description 异步任务id
     *
     * @var string
     */
    public $taskId;
    protected $_name = [
        'file'   => 'file',
        'taskId' => 'taskId',
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
        if (null !== $this->taskId) {
            $res['taskId'] = $this->taskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CopyFileResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['file'])) {
            $model->file = file::fromMap($map['file']);
        }
        if (isset($map['taskId'])) {
            $model->taskId = $map['taskId'];
        }

        return $model;
    }
}
