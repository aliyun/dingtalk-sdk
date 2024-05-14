<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\ChatMemoAddGeneralFileRequest\tagList;
use AlibabaCloud\Tea\Model;

class ChatMemoAddGeneralFileRequest extends Model
{
    /**
     * @example aaaaa
     *
     * @var string
     */
    public $bizId;

    /**
     * @description This parameter is required.
     *
     * @example 111111
     *
     * @var int
     */
    public $datasetId;

    /**
     * @description This parameter is required.
     *
     * @example https://xxxxxxx.com/xxxxxx
     *
     * @var string
     */
    public $downloadUrl;

    /**
     * @example 这是一个财务制度相关的文件
     *
     * @var string
     */
    public $fileDesc;

    /**
     * @description This parameter is required.
     *
     * @example aaa.doc
     *
     * @var string
     */
    public $fileName;

    /**
     * @var tagList[]
     */
    public $tagList;
    protected $_name = [
        'bizId'       => 'bizId',
        'datasetId'   => 'datasetId',
        'downloadUrl' => 'downloadUrl',
        'fileDesc'    => 'fileDesc',
        'fileName'    => 'fileName',
        'tagList'     => 'tagList',
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
        if (null !== $this->datasetId) {
            $res['datasetId'] = $this->datasetId;
        }
        if (null !== $this->downloadUrl) {
            $res['downloadUrl'] = $this->downloadUrl;
        }
        if (null !== $this->fileDesc) {
            $res['fileDesc'] = $this->fileDesc;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->tagList) {
            $res['tagList'] = [];
            if (null !== $this->tagList && \is_array($this->tagList)) {
                $n = 0;
                foreach ($this->tagList as $item) {
                    $res['tagList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ChatMemoAddGeneralFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizId'])) {
            $model->bizId = $map['bizId'];
        }
        if (isset($map['datasetId'])) {
            $model->datasetId = $map['datasetId'];
        }
        if (isset($map['downloadUrl'])) {
            $model->downloadUrl = $map['downloadUrl'];
        }
        if (isset($map['fileDesc'])) {
            $model->fileDesc = $map['fileDesc'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['tagList'])) {
            if (!empty($map['tagList'])) {
                $model->tagList = [];
                $n              = 0;
                foreach ($map['tagList'] as $item) {
                    $model->tagList[$n++] = null !== $item ? tagList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
