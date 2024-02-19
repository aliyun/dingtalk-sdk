<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class SyncReceiptRecallRequest extends Model
{
    /**
     * @example https:xxxx.pdf
     *
     * @var string
     */
    public $fileDownloadUrl;

    /**
     * @example 1234.pdf
     *
     * @var string
     */
    public $fileName;

    /**
     * @example 123
     *
     * @var string
     */
    public $orderNo;
    protected $_name = [
        'fileDownloadUrl' => 'fileDownloadUrl',
        'fileName'        => 'fileName',
        'orderNo'         => 'orderNo',
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
        if (null !== $this->orderNo) {
            $res['orderNo'] = $this->orderNo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SyncReceiptRecallRequest
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
        if (isset($map['orderNo'])) {
            $model->orderNo = $map['orderNo'];
        }

        return $model;
    }
}
