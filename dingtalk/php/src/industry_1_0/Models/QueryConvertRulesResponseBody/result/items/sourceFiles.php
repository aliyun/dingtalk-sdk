<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryConvertRulesResponseBody\result\items;

use AlibabaCloud\Tea\Model;

class sourceFiles extends Model
{
    /**
     * @var string
     */
    public $fileName;

    /**
     * @var float
     */
    public $fileSize;

    /**
     * @var string
     */
    public $fileTag;

    /**
     * @var string
     */
    public $mediaId;

    /**
     * @var string
     */
    public $previewUrl;
    protected $_name = [
        'fileName' => 'fileName',
        'fileSize' => 'fileSize',
        'fileTag' => 'fileTag',
        'mediaId' => 'mediaId',
        'previewUrl' => 'previewUrl',
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
        if (null !== $this->fileTag) {
            $res['fileTag'] = $this->fileTag;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->previewUrl) {
            $res['previewUrl'] = $this->previewUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sourceFiles
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
        if (isset($map['fileTag'])) {
            $model->fileTag = $map['fileTag'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['previewUrl'])) {
            $model->previewUrl = $map['previewUrl'];
        }

        return $model;
    }
}
