<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddSpaceRequest\option;

use AlibabaCloud\Tea\Model;

class capabilities extends Model
{
    /**
     * @example true
     *
     * @var bool
     */
    public $canRecordRecentFile;

    /**
     * @example true
     *
     * @var bool
     */
    public $canRename;

    /**
     * @example true
     *
     * @var bool
     */
    public $canSearch;
    protected $_name = [
        'canRecordRecentFile' => 'canRecordRecentFile',
        'canRename' => 'canRename',
        'canSearch' => 'canSearch',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->canRecordRecentFile) {
            $res['canRecordRecentFile'] = $this->canRecordRecentFile;
        }
        if (null !== $this->canRename) {
            $res['canRename'] = $this->canRename;
        }
        if (null !== $this->canSearch) {
            $res['canSearch'] = $this->canSearch;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return capabilities
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['canRecordRecentFile'])) {
            $model->canRecordRecentFile = $map['canRecordRecentFile'];
        }
        if (isset($map['canRename'])) {
            $model->canRename = $map['canRename'];
        }
        if (isset($map['canSearch'])) {
            $model->canSearch = $map['canSearch'];
        }

        return $model;
    }
}
