<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vmail_1_0\Models\CreateMailFolderResponseBody\folder;
use AlibabaCloud\Tea\Model;

class CreateMailFolderResponseBody extends Model
{
    /**
     * @var folder
     */
    public $folder;

    /**
     * @var string
     */
    public $requestId;
    protected $_name = [
        'folder' => 'folder',
        'requestId' => 'requestId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->folder) {
            $res['folder'] = null !== $this->folder ? $this->folder->toMap() : null;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateMailFolderResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['folder'])) {
            $model->folder = folder::fromMap($map['folder']);
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }

        return $model;
    }
}
