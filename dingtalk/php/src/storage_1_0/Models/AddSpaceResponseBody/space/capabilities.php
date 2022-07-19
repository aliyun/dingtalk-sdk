<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddSpaceResponseBody\space;

use AlibabaCloud\Tea\Model;

class capabilities extends Model
{
    /**
     * @description 是否进最近使用, 默认不支持
     * false
     * @var bool
     */
    public $canRecordRecentFile;

    /**
     * @description 是否支持重命名空间名称, 默认不支持
     * false
     * @var bool
     */
    public $canRename;

    /**
     * @description 是否支持搜索, 默认不支持
     * false
     * @var bool
     */
    public $canSearch;
    protected $_name = [
        'canRecordRecentFile' => 'canRecordRecentFile',
        'canRename'           => 'canRename',
        'canSearch'           => 'canSearch',
    ];

    public function validate()
    {
    }

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
