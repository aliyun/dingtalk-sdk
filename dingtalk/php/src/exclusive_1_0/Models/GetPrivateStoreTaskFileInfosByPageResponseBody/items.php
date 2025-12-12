<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetPrivateStoreTaskFileInfosByPageResponseBody;

use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @example 普通文件
     *
     * @var string
     */
    public $classTagName;

    /**
     * @example 1234
     *
     * @var string
     */
    public $dentryId;

    /**
     * @example 1234566
     *
     * @var int
     */
    public $fileCreateTime;

    /**
     * @example 安装包
     *
     * @var string
     */
    public $fileFormatName;

    /**
     * @example 1234566
     *
     * @var int
     */
    public $fileModifiedTime;

    /**
     * @example 我的表格.xls
     *
     * @var string
     */
    public $fileName;

    /**
     * @example 钉钉云盘
     *
     * @var string
     */
    public $fileScopeName;

    /**
     * @example 1GB
     *
     * @var string
     */
    public $fileSizeName;

    /**
     * @example 1234
     *
     * @var int
     */
    public $spaceId;
    protected $_name = [
        'classTagName' => 'classTagName',
        'dentryId' => 'dentryId',
        'fileCreateTime' => 'fileCreateTime',
        'fileFormatName' => 'fileFormatName',
        'fileModifiedTime' => 'fileModifiedTime',
        'fileName' => 'fileName',
        'fileScopeName' => 'fileScopeName',
        'fileSizeName' => 'fileSizeName',
        'spaceId' => 'spaceId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->classTagName) {
            $res['classTagName'] = $this->classTagName;
        }
        if (null !== $this->dentryId) {
            $res['dentryId'] = $this->dentryId;
        }
        if (null !== $this->fileCreateTime) {
            $res['fileCreateTime'] = $this->fileCreateTime;
        }
        if (null !== $this->fileFormatName) {
            $res['fileFormatName'] = $this->fileFormatName;
        }
        if (null !== $this->fileModifiedTime) {
            $res['fileModifiedTime'] = $this->fileModifiedTime;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->fileScopeName) {
            $res['fileScopeName'] = $this->fileScopeName;
        }
        if (null !== $this->fileSizeName) {
            $res['fileSizeName'] = $this->fileSizeName;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classTagName'])) {
            $model->classTagName = $map['classTagName'];
        }
        if (isset($map['dentryId'])) {
            $model->dentryId = $map['dentryId'];
        }
        if (isset($map['fileCreateTime'])) {
            $model->fileCreateTime = $map['fileCreateTime'];
        }
        if (isset($map['fileFormatName'])) {
            $model->fileFormatName = $map['fileFormatName'];
        }
        if (isset($map['fileModifiedTime'])) {
            $model->fileModifiedTime = $map['fileModifiedTime'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['fileScopeName'])) {
            $model->fileScopeName = $map['fileScopeName'];
        }
        if (isset($map['fileSizeName'])) {
            $model->fileSizeName = $map['fileSizeName'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }

        return $model;
    }
}
