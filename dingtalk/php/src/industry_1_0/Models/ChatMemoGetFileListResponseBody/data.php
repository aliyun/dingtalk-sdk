<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoGetFileListResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example xxxx
     *
     * @var string
     */
    public $bizId;

    /**
     * @example 财务制度文件
     *
     * @var string
     */
    public $fileDesc;

    /**
     * @example aaaaa.doc
     *
     * @var string
     */
    public $fileName;

    /**
     * @example yyyyyy-aaaaaa-bbbbb-cccccccccc.docx
     *
     * @var string
     */
    public $mediaId;

    /**
     * @var string[][]
     */
    public $tagMap;
    protected $_name = [
        'bizId' => 'bizId',
        'fileDesc' => 'fileDesc',
        'fileName' => 'fileName',
        'mediaId' => 'mediaId',
        'tagMap' => 'tagMap',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizId) {
            $res['bizId'] = $this->bizId;
        }
        if (null !== $this->fileDesc) {
            $res['fileDesc'] = $this->fileDesc;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->tagMap) {
            $res['tagMap'] = $this->tagMap;
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
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['fileDesc'])) {
            $model->fileDesc = $map['fileDesc'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['tagMap'])) {
            $model->tagMap = $map['tagMap'];
        }

        return $model;
    }
}
