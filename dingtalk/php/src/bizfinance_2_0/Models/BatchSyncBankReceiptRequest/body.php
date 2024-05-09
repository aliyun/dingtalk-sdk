<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models\BatchSyncBankReceiptRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @example https://xxxxx
     *
     * @var string
     */
    public $fileDownloadUrl;

    /**
     * @example xxxx回单.pdf
     *
     * @var string
     */
    public $fileName;

    /**
     * @example 2024000001902335
     *
     * @var string
     */
    public $messageId;

    /**
     * @example detailId
     *
     * @var string
     */
    public $messageIdType;
    protected $_name = [
        'fileDownloadUrl' => 'fileDownloadUrl',
        'fileName'        => 'fileName',
        'messageId'       => 'messageId',
        'messageIdType'   => 'messageIdType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileDownloadUrl) {
            $res['fileDownloadUrl'] = $this->fileDownloadUrl;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->messageId) {
            $res['messageId'] = $this->messageId;
        }
        if (null !== $this->messageIdType) {
            $res['messageIdType'] = $this->messageIdType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileDownloadUrl'])) {
            $model->fileDownloadUrl = $map['fileDownloadUrl'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['messageId'])) {
            $model->messageId = $map['messageId'];
        }
        if (isset($map['messageIdType'])) {
            $model->messageIdType = $map['messageIdType'];
        }

        return $model;
    }
}
