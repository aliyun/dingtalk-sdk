<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListMailFoldersRequest extends Model
{
    /**
     * @var string
     */
    public $folderId;
    protected $_name = [
        'folderId' => 'folderId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->folderId) {
            $res['folderId'] = $this->folderId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListMailFoldersRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['folderId'])) {
            $model->folderId = $map['folderId'];
        }

        return $model;
    }
}
