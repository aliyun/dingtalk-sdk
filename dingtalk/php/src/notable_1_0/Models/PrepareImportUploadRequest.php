<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models;

use AlibabaCloud\Tea\Model;

class PrepareImportUploadRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $fileExtension;

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
     * @var string[]
     */
    public $tableNames;

    /**
     * @description This parameter is required.
     *
     * @example union_id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'fileExtension' => 'fileExtension',
        'fileName' => 'fileName',
        'fileSize' => 'fileSize',
        'tableNames' => 'tableNames',
        'operatorId' => 'operatorId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->fileExtension) {
            $res['fileExtension'] = $this->fileExtension;
        }
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->tableNames) {
            $res['tableNames'] = $this->tableNames;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PrepareImportUploadRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileExtension'])) {
            $model->fileExtension = $map['fileExtension'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['tableNames'])) {
            if (!empty($map['tableNames'])) {
                $model->tableNames = $map['tableNames'];
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
