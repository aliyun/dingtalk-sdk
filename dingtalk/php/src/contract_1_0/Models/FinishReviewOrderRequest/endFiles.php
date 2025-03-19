<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\FinishReviewOrderRequest;

use AlibabaCloud\Tea\Model;

class endFiles extends Model
{
    /**
     * @example 合同文件
     *
     * @var string
     */
    public $fileName;

    /**
     * @example 12
     *
     * @var string
     */
    public $fileSize;

    /**
     * @example word
     *
     * @var string
     */
    public $fileType;

    /**
     * @example 0
     *
     * @var int
     */
    public $fileVersion;

    /**
     * @example http://oss.com
     *
     * @var string
     */
    public $url;
    protected $_name = [
        'fileName' => 'fileName',
        'fileSize' => 'fileSize',
        'fileType' => 'fileType',
        'fileVersion' => 'fileVersion',
        'url' => 'url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->fileType) {
            $res['fileType'] = $this->fileType;
        }
        if (null !== $this->fileVersion) {
            $res['fileVersion'] = $this->fileVersion;
        }
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return endFiles
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['fileType'])) {
            $model->fileType = $map['fileType'];
        }
        if (isset($map['fileVersion'])) {
            $model->fileVersion = $map['fileVersion'];
        }
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}
