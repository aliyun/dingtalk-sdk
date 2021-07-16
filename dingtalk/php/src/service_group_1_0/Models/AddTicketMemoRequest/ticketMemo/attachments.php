<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\AddTicketMemoRequest\ticketMemo;

use AlibabaCloud\Tea\Model;

class attachments extends Model
{
    /**
     * @description 文件名
     *
     * @var string
     */
    public $fileName;

    /**
     * @description 文件key
     *
     * @var string
     */
    public $key;
    protected $_name = [
        'fileName' => 'fileName',
        'key'      => 'key',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->key) {
            $res['key'] = $this->key;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return attachments
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['key'])) {
            $model->key = $map['key'];
        }

        return $model;
    }
}
