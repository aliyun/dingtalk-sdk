<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class FileDecryptCallbackRequest extends Model
{
    /**
     * @var string
     */
    public $bizId;

    /**
     * @var int
     */
    public $decryptFileSize;

    /**
     * @var int
     */
    public $timestamp;
    protected $_name = [
        'bizId' => 'bizId',
        'decryptFileSize' => 'decryptFileSize',
        'timestamp' => 'timestamp',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->decryptFileSize) {
            $res['decryptFileSize'] = $this->decryptFileSize;
        }
        if (null !== $this->timestamp) {
            $res['timestamp'] = $this->timestamp;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return FileDecryptCallbackRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['decryptFileSize'])) {
            $model->decryptFileSize = $map['decryptFileSize'];
        }
        if (isset($map['timestamp'])) {
            $model->timestamp = $map['timestamp'];
        }

        return $model;
    }
}
