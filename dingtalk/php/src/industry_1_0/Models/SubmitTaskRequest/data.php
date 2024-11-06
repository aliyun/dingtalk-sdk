<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SubmitTaskRequest;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example 2024-05-14
     *
     * @var string
     */
    public $date;

    /**
     * @example xx项目
     *
     * @var string
     */
    public $desc;

    /**
     * @example 根据不同业务类型，传业务需求的JSON字符串
     *
     * @var string
     */
    public $extension;

    /**
     * @example audio
     *
     * @var string
     */
    public $fileType;

    /**
     * @var string[]
     */
    public $fileUrl;

    /**
     * @example 1001
     *
     * @var int
     */
    public $id;

    /**
     * @example xx项目会议
     *
     * @var string
     */
    public $name;
    protected $_name = [
        'date'      => 'date',
        'desc'      => 'desc',
        'extension' => 'extension',
        'fileType'  => 'fileType',
        'fileUrl'   => 'fileUrl',
        'id'        => 'id',
        'name'      => 'name',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->date) {
            $res['date'] = $this->date;
        }
        if (null !== $this->desc) {
            $res['desc'] = $this->desc;
        }
        if (null !== $this->extension) {
            $res['extension'] = $this->extension;
        }
        if (null !== $this->fileType) {
            $res['fileType'] = $this->fileType;
        }
        if (null !== $this->fileUrl) {
            $res['fileUrl'] = $this->fileUrl;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
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
        if (isset($map['date'])) {
            $model->date = $map['date'];
        }
        if (isset($map['desc'])) {
            $model->desc = $map['desc'];
        }
        if (isset($map['extension'])) {
            $model->extension = $map['extension'];
        }
        if (isset($map['fileType'])) {
            $model->fileType = $map['fileType'];
        }
        if (isset($map['fileUrl'])) {
            if (!empty($map['fileUrl'])) {
                $model->fileUrl = $map['fileUrl'];
            }
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }

        return $model;
    }
}
