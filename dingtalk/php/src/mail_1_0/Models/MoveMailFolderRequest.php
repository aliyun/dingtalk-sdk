<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models;

use AlibabaCloud\Tea\Model;

class MoveMailFolderRequest extends Model
{
    /**
     * @var string
     */
    public $destinationFolderId;
    protected $_name = [
        'destinationFolderId' => 'destinationFolderId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->destinationFolderId) {
            $res['destinationFolderId'] = $this->destinationFolderId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return MoveMailFolderRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['destinationFolderId'])) {
            $model->destinationFolderId = $map['destinationFolderId'];
        }

        return $model;
    }
}
