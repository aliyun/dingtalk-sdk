<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetFileResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $fileId;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $downloadUrl;

    /**
     * @var int
     */
    public $size;

    /**
     * @var int
     */
    public $status;

    /**
     * @var int
     */
    public $pdfTotalPages;
    protected $_name = [
        'fileId'        => 'fileId',
        'name'          => 'name',
        'downloadUrl'   => 'downloadUrl',
        'size'          => 'size',
        'status'        => 'status',
        'pdfTotalPages' => 'pdfTotalPages',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileId) {
            $res['fileId'] = $this->fileId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->downloadUrl) {
            $res['downloadUrl'] = $this->downloadUrl;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->pdfTotalPages) {
            $res['pdfTotalPages'] = $this->pdfTotalPages;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['downloadUrl'])) {
            $model->downloadUrl = $map['downloadUrl'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['pdfTotalPages'])) {
            $model->pdfTotalPages = $map['pdfTotalPages'];
        }

        return $model;
    }
}
