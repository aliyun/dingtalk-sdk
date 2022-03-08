<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\CopyFileResponseBody;

use AlibabaCloud\Tea\Model;

class file extends Model
{
    /**
     * @description 文件内容类型
     *
     * @var string
     */
    public $contentType;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $createTime;

    /**
     * @description 创建者
     *
     * @var string
     */
    public $creator;

    /**
     * @description 文件后缀
     *
     * @var string
     */
    public $fileExtension;

    /**
     * @description 文件id
     *
     * @var string
     */
    public $fileId;

    /**
     * @description 文件名称
     *
     * @var string
     */
    public $fileName;

    /**
     * @description 文件路径
     *
     * @var string
     */
    public $filePath;

    /**
     * @description 文件大小
     *
     * @var int
     */
    public $fileSize;

    /**
     * @description 文件类型
     *
     * @var string
     */
    public $fileType;

    /**
     * @description 修改者
     *
     * @var string
     */
    public $modifier;

    /**
     * @description 修改时间
     *
     * @var string
     */
    public $modifyTime;

    /**
     * @description 父目录id
     *
     * @var string
     */
    public $parentId;

    /**
     * @description 空间id
     *
     * @var string
     */
    public $spaceId;
    protected $_name = [
        'contentType'   => 'contentType',
        'createTime'    => 'createTime',
        'creator'       => 'creator',
        'fileExtension' => 'fileExtension',
        'fileId'        => 'fileId',
        'fileName'      => 'fileName',
        'filePath'      => 'filePath',
        'fileSize'      => 'fileSize',
        'fileType'      => 'fileType',
        'modifier'      => 'modifier',
        'modifyTime'    => 'modifyTime',
        'parentId'      => 'parentId',
        'spaceId'       => 'spaceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contentType) {
            $res['contentType'] = $this->contentType;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->creator) {
            $res['creator'] = $this->creator;
        }
        if (null !== $this->fileExtension) {
            $res['fileExtension'] = $this->fileExtension;
        }
        if (null !== $this->fileId) {
            $res['fileId'] = $this->fileId;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->filePath) {
            $res['filePath'] = $this->filePath;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->fileType) {
            $res['fileType'] = $this->fileType;
        }
        if (null !== $this->modifier) {
            $res['modifier'] = $this->modifier;
        }
        if (null !== $this->modifyTime) {
            $res['modifyTime'] = $this->modifyTime;
        }
        if (null !== $this->parentId) {
            $res['parentId'] = $this->parentId;
        }
        if (null !== $this->spaceId) {
            $res['spaceId'] = $this->spaceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return file
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contentType'])) {
            $model->contentType = $map['contentType'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['creator'])) {
            $model->creator = $map['creator'];
        }
        if (isset($map['fileExtension'])) {
            $model->fileExtension = $map['fileExtension'];
        }
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['filePath'])) {
            $model->filePath = $map['filePath'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['fileType'])) {
            $model->fileType = $map['fileType'];
        }
        if (isset($map['modifier'])) {
            $model->modifier = $map['modifier'];
        }
        if (isset($map['modifyTime'])) {
            $model->modifyTime = $map['modifyTime'];
        }
        if (isset($map['parentId'])) {
            $model->parentId = $map['parentId'];
        }
        if (isset($map['spaceId'])) {
            $model->spaceId = $map['spaceId'];
        }

        return $model;
    }
}
