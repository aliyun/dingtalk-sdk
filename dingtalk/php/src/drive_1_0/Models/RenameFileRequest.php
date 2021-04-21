<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models;

use AlibabaCloud\Tea\Model;

class RenameFileRequest extends Model
{
    /**
     * @description 新文件名称
     *
     * @var string
     */
    public $newFileName;
    protected $_name = [
        'newFileName' => 'newFileName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->newFileName) {
            $res['newFileName'] = $this->newFileName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RenameFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['newFileName'])) {
            $model->newFileName = $map['newFileName'];
        }

        return $model;
    }
}
