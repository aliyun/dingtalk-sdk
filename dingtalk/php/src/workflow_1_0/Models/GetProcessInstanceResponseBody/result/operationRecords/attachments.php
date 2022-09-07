<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceResponseBody\result\operationRecords;

use AlibabaCloud\Tea\Model;

class attachments extends Model
{
    /**
     * @description 附件ID。
     *
     * @var string
     */
    public $fileId;

    /**
     * @description 附件名称。
     *
     * @var string
     */
    public $fileName;

    /**
     * @description 附件大小。
     *
     * @var string
     */
    public $fileSize;

    /**
     * @description 附件类型。
     *
     * @var string
     */
    public $fileType;
    protected $_name = [
        'fileId'   => 'fileId',
        'fileName' => 'fileName',
        'fileSize' => 'fileSize',
        'fileType' => 'fileType',
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
        if (null !== $this->fileName) {
            $res['fileName'] = $this->fileName;
        }
        if (null !== $this->fileSize) {
            $res['fileSize'] = $this->fileSize;
        }
        if (null !== $this->fileType) {
            $res['fileType'] = $this->fileType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return attachments
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fileId'])) {
            $model->fileId = $map['fileId'];
        }
        if (isset($map['fileName'])) {
            $model->fileName = $map['fileName'];
        }
        if (isset($map['fileSize'])) {
            $model->fileSize = $map['fileSize'];
        }
        if (isset($map['fileType'])) {
            $model->fileType = $map['fileType'];
        }

        return $model;
    }
}
