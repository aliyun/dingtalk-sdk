<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendFileMessageRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $extension;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fileName;

    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $fileSize;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fileUrl;

    /**
     * @var string
     */
    public $sendType;
    protected $_name = [
        'bizId'     => 'bizId',
        'extension' => 'extension',
        'fileName'  => 'fileName',
        'fileSize'  => 'fileSize',
        'fileUrl'   => 'fileUrl',
        'sendType'  => 'sendType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->fileUrl) {
            $res['fileUrl'] = $this->fileUrl;
        }
        if (null !== $this->sendType) {
            $res['sendType'] = $this->sendType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendFileMessageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['fileUrl'])) {
            $model->fileUrl = $map['fileUrl'];
        }
        if (isset($map['sendType'])) {
            $model->sendType = $map['sendType'];
        }

        return $model;
    }
}
